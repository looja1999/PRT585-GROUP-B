import React from 'react'
import Button from 'react-bootstrap/Button';
import Container from 'react-bootstrap/Container';
import Form from 'react-bootstrap/Form';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';

function NavBar() {
  return (
    <Navbar bg="primary" expand="lg">
    <Container fluid>
      <Navbar.Brand href="/">Course Support System</Navbar.Brand>
      <Navbar.Toggle aria-controls="navbarScroll" />
      <Navbar.Collapse id="navbarScroll">
        <Nav
          className="me-auto my-2 my-lg-0"
          style={{ maxHeight: '100px' }}
          navbarScroll
        >
          <Nav.Link href="/">Home</Nav.Link>
          <NavDropdown title="Student" id="navbarScrollingDropdown">
          <NavDropdown.Item href="#MyCourse">My Course</NavDropdown.Item>
            <NavDropdown.Item href="#My Grade">My Grade</NavDropdown.Item>
            <NavDropdown.Item href="#action3">My Graduation</NavDropdown.Item>
            <NavDropdown.Item href="#action3">My Report</NavDropdown.Item>
            <NavDropdown.Item href="#action9">Settings</NavDropdown.Item>
          </NavDropdown>
          <NavDropdown title="Course Coordinator" id="navbarScrollingDropdown">
          <NavDropdown.Item href="#Course">Course</NavDropdown.Item>
            <NavDropdown.Item href="#Report">Report</NavDropdown.Item>
            <NavDropdown.Item href="#Unit">Unit</NavDropdown.Item>
            <NavDropdown.Item href="#Setting">Setting</NavDropdown.Item>
          </NavDropdown>
          <NavDropdown title="Graduation" id="navbarScrollingDropdown">
            <NavDropdown.Item href="graduation">Graduation Report</NavDropdown.Item>
            <NavDropdown.Item href="#action4">
             Graduation Reservation
            </NavDropdown.Item>
            <NavDropdown.Divider />
            <NavDropdown.Item href="#action5">
              Graduation Day
            </NavDropdown.Item>
          </NavDropdown>
         
          <NavDropdown title="System Admin" id="navbarScrollingDropdown">
            <NavDropdown.Item href="#action3">Role</NavDropdown.Item>
            <NavDropdown.Item href="#action4">
              Feature
            </NavDropdown.Item>
            <NavDropdown.Divider />
            <NavDropdown.Item href="#action5">
              Something else here
            </NavDropdown.Item>
          </NavDropdown>
         
        </Nav>
        <Form className="d-flex">
          <Form.Control
            type="search"
            placeholder="Search"
            className="me-2"
            aria-label="Search"
          />
          <Button variant="secondary">Search</Button>
        </Form>
      </Navbar.Collapse>
    </Container>
  </Navbar>
  )
}

export default NavBar