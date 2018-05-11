import React, { Component } from 'react';
import Moment from 'react-moment';
import '../new.css';
export class Detail extends Component{
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
    fetch('http://localhost:5000/api/Detail/')
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
              <b>Category:  </b> {items.categoryId} <br/>
              <b>Place: </b>  {items.place} <br/>
            
              <b>Date of flight: </b>
              <Moment format="MM/DD/YYYY">
              {items.dateFlight}
            </Moment>  <br/>

                <b>Date of sale: </b>
              <Moment format="MM/DD/YYYY" >
              {items.dateOfSale}
            </Moment> <br/>

              <b>Price: </b>  {items.price} <br/>
            </p>
            )
          })} 
           
          </div>
    )
  }
}
export default Detail;