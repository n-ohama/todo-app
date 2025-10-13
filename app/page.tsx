"use client"

import { useEffect, useState } from "react";
import { addTodoS, fetchTodoS, Todo } from "./supabase";

export default function Home() {
  const [inputText, setInputText] = useState("");
  const [todos, setTodos] = useState<Todo[]>([]);

  const fAAA = async () => {
    const aaa = await fetchTodoS();
    setTodos(aaa);
  }

  useEffect(() => {
    fAAA();
  }, []);

  return (
    <div>
      <div className="flex">
        <input type="text" value={inputText} onChange={e => setInputText(e.target.value)} />
        <button onClick={async () => {
          await addTodoS(inputText);
          await fAAA();
          setInputText("");
        }}>ADD</button>
      </div>

      <div>
        {todos.map((item, i) => (
          <div key={i}>{item.todo_item}</div>
        ))}
      </div>
    </div>
  );
}
