import { createClient } from '@supabase/supabase-js'

const supabaseUrl = process.env.NEXT_PUBLIC_SUPABASE_URL!
const supabaseKey = process.env.NEXT_PUBLIC_SUPABASE_ANON_KEY!

export const supabase = createClient(supabaseUrl, supabaseKey);

export type Todo = {
    id: number; todo_item: string; created_at: string;
}

export const addTodoS = async (todo: string) => {
    await supabase.from("todos").insert({
        todo_item: todo,
    });
}

export const fetchTodoS = async () => {
    const response = await supabase.from("todos").select('*');

    if (response.error) {
        return [];
    }

    return response.data as Todo[];
}
