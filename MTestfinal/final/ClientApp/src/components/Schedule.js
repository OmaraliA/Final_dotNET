import React, { Component } from 'react';
import Moment from 'react-moment';
import '../new.css';
export class Schedule extends Component{
  constructor(props){
    super(props);
    this.state = {
      categories:[],
      dates:props.info,
    }
  }
  componentDidMount() {
    this.loadData();
   
  }

  loadData = async() => {
    fetch('http://localhost:5000/api/Category/')
      .then(datas => datas.json())
      .then((datas) => {
        this.setState({ categories: datas })
      });
    
  }
  render(){  
    return( 
          <div className="sch">
            {this.state.categories.map((items, j) => {
             
            return (
            
                <p>
              <b>Category:  </b> {items.flightID} <br/>
              <b>Plain Name: </b>  {items.plainName} <br/>
              <b>Destination: </b>  {items.destination} <br/>
              <b>Flight </b>
              <Moment format="HH:mm" >
              {items.flight}
            </Moment>
            </p>
          

            
            )
          })} 
           
          </div>
    )
  }
}
export default Schedule;