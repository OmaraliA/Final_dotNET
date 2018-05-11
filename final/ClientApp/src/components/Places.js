import React, { Component } from 'react';
import Moment from 'react-moment';
import '../new.css';
export class Places extends Component{
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
    fetch('http://localhost:5000/api/Product/')
      .then(datas => datas.json())
      .then((datas) => {
        this.setState({ categories: datas })
      });
    
  }
  render(){  
    return( 
          <div className="sch">
            {this.state.categories.map((items, j) => {
             if (items.categoryId<=1) {
            return (
            
                <p>
             
              <b>Place Number: </b>  {items.placeNumber} <br/>
              <b>Price </b>  {items.price} <br/>
           
            </p>
            )}
          })} 
           
          </div>
    )
  }
}
export default Places;