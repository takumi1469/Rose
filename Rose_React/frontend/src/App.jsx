import { useState, useEffect } from 'react'
import './App.css'
import AdminPanel from './AdminPanel';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { useNavigate } from 'react-router-dom';
import { Link } from 'react-router-dom';
import { useLocation } from 'react-router-dom';

function App() {

  return (
    <>
      <header className='m-5 lg:m-10'>
        <a href="/"><h1 className='text-pink-800'>ROSE</h1></a>
        <a href="/admin" className='ml-2'><p>Admin Panel</p></a>
      </header>
      <div className="div-main ml-3 mr-3 lg:ml-8 lg:mr-8">
        <Router>
          <Routes>
            <Route path="/" element={<Dashboard />} />
            <Route path="/admin" element={<AdminPanel />} />
          </Routes>
        </Router>
      </div>

    </>
  );
}

const Dashboard = () => {

  const receiveData = () => {
    fetch('https://localhost:7242/api/PassDataToReact')
      .then(response => {
        if (!response.ok) {
          console.log("Receiving failed");}
          return response.json();
        }
      )
      .then(response => {
        console.log(response[29].year)
      })
      .catch(error => {
        alert('Error occurred');
      });
  }

  return (
  <div className='div-graph w-10/12 bg-blue-400 h-5/12'>
    <h2 className='text-3xl lg:text-5xl'>Graph</h2>
    <button className=" bg-blue-950 text-white " onClick={receiveData}>Receive data</button>
  </div>
  );
}

export default App