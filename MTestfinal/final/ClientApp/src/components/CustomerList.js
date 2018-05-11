import React, { Component } from 'react';
import '../App.css';
import Moment from 'react-moment';

 class CustomerList extends Component{
  constructor(props){
    super(props);
    this.state = {
      date:props.info,
    }
  
 
  }

  


  render(){
   console.log(this.state.date.dateofflight);

  
  // var date = ddd.toLocaleDateString();
  
    return( 
          <div className="Card" >
            <p>
              <b>Name: </b> {this.state.date.name} <br/>
              <b>Surname:</b> {this.state.date.surname} <br/>
              <b>Passport Number: </b> {this.state.date.passportNumber} <br/>
              <b>Date of flight: </b>
              <Moment format="MM/DD/YYYY" >
              {this.state.date.dateOfFlight}
            </Moment>
            </p>
          </div>
    )
  }
}
export default CustomerList ;