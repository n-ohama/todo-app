🔸見た目
<img width="1467" height="438" alt="スクリーンショット 2025-10-13 16 03 47" src="https://github.com/user-attachments/assets/31f39151-6aee-4d8b-9d4a-9033f2b9b742" />


🔸 supabase.comで`todos`テーブルを作成
todosテーブル
```
id: int, created_at: timestamp, todo_item: text
※id、created_atはデフォルトで作られたはず...
```

<img width="1465" height="605" alt="スクリーンショット 2025-10-13 16 00 16" src="https://github.com/user-attachments/assets/0e06f120-349c-4ac8-8fa0-f175ca3803f7" />

### 🔸Enable Row Level Security (RLS)のチェックを外す（ここ大事！！！！）
<img width="684" height="797" alt="スクリーンショット 2025-10-13 17 08 04" src="https://github.com/user-attachments/assets/36b19599-c369-4bff-8405-d2e9fcde71b0" />


🔸プロジェクト直下に.env.localを作成

`NEXT_PUBLIC_SUPABASE_URL=`

`NEXT_PUBLIC_SUPABASE_ANON_KEY=`

<img width="1449" height="587" alt="スクリーンショット 2025-10-13 15 56 55" src="https://github.com/user-attachments/assets/3d1adae5-bf5a-48a5-9b1d-8ac665ffa879" />



This is a [Next.js](https://nextjs.org) project bootstrapped with [`create-next-app`](https://nextjs.org/docs/app/api-reference/cli/create-next-app).

## Getting Started

First, run the development server:

```bash
npm run dev
# or
yarn dev
# or
pnpm dev
# or
bun dev
```

Open [http://localhost:3000](http://localhost:3000) with your browser to see the result.

You can start editing the page by modifying `app/page.tsx`. The page auto-updates as you edit the file.

This project uses [`next/font`](https://nextjs.org/docs/app/building-your-application/optimizing/fonts) to automatically optimize and load [Geist](https://vercel.com/font), a new font family for Vercel.

## Learn More

To learn more about Next.js, take a look at the following resources:

- [Next.js Documentation](https://nextjs.org/docs) - learn about Next.js features and API.
- [Learn Next.js](https://nextjs.org/learn) - an interactive Next.js tutorial.

You can check out [the Next.js GitHub repository](https://github.com/vercel/next.js) - your feedback and contributions are welcome!

## Deploy on Vercel

The easiest way to deploy your Next.js app is to use the [Vercel Platform](https://vercel.com/new?utm_medium=default-template&filter=next.js&utm_source=create-next-app&utm_campaign=create-next-app-readme) from the creators of Next.js.

Check out our [Next.js deployment documentation](https://nextjs.org/docs/app/building-your-application/deploying) for more details.
