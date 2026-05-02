'use client'

import { useEffect, useState } from 'react'

export default function Home() {
  const [data, setData] = useState(null)

  useEffect(() => {
    fetch('https://localhost:5001/weatherforecast')
      .then(res => res.json())
      .then(setData)
  }, [])

  return (
    <div>
      <h1>Backend Test</h1>
      <pre>{JSON.stringify(data, null, 2)}</pre>
    </div>
  )
}