import React from 'react'
import { Button, Container,Table } from 'react-bootstrap'

function Graduation() {
  return (
    <div className='mt-4'><Container >GReport List
        
        <Button style={{ float: "right",borderRadius:'0px'}} className="background-none text-black">
            Add GReport
            </Button>
            
            <hr></hr>
            <p>NO REPORTS AVAILABLE!!!
                
            <Table bordered responsive>
      <thead>
        <tr className='bg-secondary text-white'>
          
          {/* {Array.from({ length: 3 }).map((_, index) => (
            <th key={index}>Table heading</th> */}

          {/* ))} */}
        </tr>
      </thead>
      <tbody>
        
        
      </tbody>
    </Table>
    </p></Container></div>


  )
}

export default Graduation