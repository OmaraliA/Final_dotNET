import React, { Component } from 'react';
import Moment from 'react-moment';
import '../new.css';
export class Master extends Component{
  constructor(props){
    super(props);
    this.state = {
      details:[],
      
    }
  }
  componentDidMount() {
    this.loadData();
   
  }

  loadData = async() => {
    fetch('http://localhost:5000/api/Master/')
      .then(datas => datas.json())
      .then((datas) => {
        this.setState({ details: datas })
      });
    
  }
  render(){  
   
    return( 
          <div className="sch">
            {this.state.details.map((items, j) => {
              
            return (
            
                <p>
              <b>Customer Name:  </b> {items.custName} <br/>
              <b>Customer Surname : </b>  {items.custSurname} <br/>
              <b>Customer Document Number : </b>  {items.custDocument} <br/>

                <b>Date of sale: </b>
              <Moment format="MM/DD/YYYY" >
              {items.dateOfSale}
            </Moment> <br/>

        
            </p>
            )
          })} 
           
          </div>
    )
  }
}
export default Master;