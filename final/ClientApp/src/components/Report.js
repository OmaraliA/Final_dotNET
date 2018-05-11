import React, { Component } from 'react';
import Moment from 'react-moment';
import '../new.css';
export class Report extends Component{
  constructor(props){
    super(props);
    this.state = {
      details:[],
      masters:[],
      sumf:0,
      sums:0,
      sumt:0,
      
    }
  }
  componentDidMount() {
    this.loadData();
   
  }

  loadData = async() => {
    fetch('http://localhost:5000/api/Report/')
      .then(datas => datas.json())
      .then((datas) => {
        this.setState({ details: datas })
      }); 
  }


 
  render(){  
 
    return( 
        <div className="col-md-12">
          <div className="sch">
            {this.state.details.map((items, j) => {
             
             for (let i=0; i<this.state.details.length; i++) {
                if (items.categoryId==1) {
                  this.state.sumf+=this.state.details[i].price;
                }
             }
              if  (items.categoryId==1) {
               
            return (
                <div  className="col-md-4">
            <p>
              <h2>Air Astana </h2>
             <b>Customer Name:  </b> {items.custName} <br/>
              <b>Customer Surname: </b>  {items.custSurname} <br/>
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
            </div>
            )}

            else if  (items.categoryId==2) {
               
                return (
                    <div  className="col-md-4">
                <p>
                  <h2>Bek Astana </h2>
                 <b>Customer Name:  </b> {items.custName} <br/>
                  <b>Customer Surname: </b>  {items.custSurname} <br/>
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
                
                </div>
                
                )}

                else if  (items.categoryId==3) {
               
                    return (
                        <div  className="col-md-4">
                    <p>
                      <h2>Scat</h2>
                     <b>Customer Name:  </b> {items.custName} <br/>
                      <b>Customer Surname: </b>  {items.custSurname} <br/>
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
                    </div>
                    )}
               

          }) 
        
        }
        </div>
          </div>
    )
  }
}
export default Report;