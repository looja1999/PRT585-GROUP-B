import React from 'react'
import Graduation from './Components/Graduation'
import Home from './Components/Home'
import {Routes,Route} from 'react-router-dom'

function NavPage() {
  return (
    <React.Fragment>
    <section className='mt-16 fixed'>
       <Routes>
    
       <Route path='/' element={<Home/>}/>
      
       <Route path='graduation' element={<Graduation/>}/>
       </Routes>
    </section>
</React.Fragment>
  )
}

export default NavPage