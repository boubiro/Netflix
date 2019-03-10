import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import './Register.css';


export class Register extends Component {
  render() {
    return (
      <div id="register-container">
        <span>STEP 2 OF 3</span>
        <h1>Sign up to start your free month.</h1>
        <div id="register">
          <form method="POST">
              <input name="email" placeholder="email"></input><br/>
              <input name="password" placeholder="password"></input><br/>
              <Link to="/signup/payment">
                <button type="submit" className="btn btn-primary btn-solid btn-oversize">Continue</button>
              </Link>
          </form>
        </div>
      </div>
    )
  }
}
