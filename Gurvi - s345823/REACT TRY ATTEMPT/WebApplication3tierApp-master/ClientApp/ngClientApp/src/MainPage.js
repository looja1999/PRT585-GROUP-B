import React from 'react'
import NavBar from './Components/NavBar'
import NavPage from './NavPage'

function MainPage() {
  return (
    <React.Fragment>

    <section>
            <div>
                <NavBar/>
            </div>
        </section>
        <section>
            
                <div className='col-span-11 bg-back   pl-2'>
                    <NavPage/>
                     
                </div>
            
            
        </section>
    </React.Fragment>
  )
}

export default MainPage