import { useState, useEffect } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {

  const [message, setMessage] = useState('');

  useEffect(() => {
    // Call API
    fetch('https://localhost:7242/Test')
      .then(response => response.text())
      .then(data => {
        setMessage(data);
      })
      .catch(error => {
        console.error('Error occurred:', error);
        setMessage('Error');
      });
  }, []);

  return (
    <>
      <header className='m-5 lg:m-10'>
        <h1 className='text-pink-800'>ROSE</h1>
      </header>
      <div className="div-main ml-3 mr-3 lg:ml-8 lg:mr-8">
        <p>{message || 'Loading...'}</p>
        <h2 className='text-3xl lg:text-5xl'>Graph</h2>
        <div className='div-graph w-10/12 bg-blue-400 h-5/12'>

        </div>
      </div>

    </>
  );
}

export default App
