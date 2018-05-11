import React, { Component } from 'react';
import '../App.css';
 class Category extends Component{
  constructor(props){
    super(props);
    this.state = {
      custDate:props.dateofflight,
    }
    this.display = this.display.bind(this); 
    
  }

  display(event){
     this.props.onUpdate(this.state.custDate)
  }


  render(){
  console.log(this.custDate);
    return( 
          <div className="NCard" >
            <p className="DDD">
             Date {this.custDate} <br/>
          
            </p>
          
          </div>
    )
  }
}
export default Category ;