import logo from './logo.svg';
import './App.css';
import NavBar from './Components/NavBar';
import Graduation from './Components/Graduation';
import MainPage from './MainPage';
import {BrowserRouter} from 'react-router-dom';
import React from 'react';



function App() {
  return (
    <div>
         <React.Fragment>
      <BrowserRouter>
      <MainPage/>
      </BrowserRouter>
    </React.Fragment>
    </div>
   
  );
}

export default App;
