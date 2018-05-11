import React, { Component } from 'react';
import Category  from './Category'
import '../new.css';
export class Add extends Component{
    constructor(props){
        super(props);
        this.state = {
         
         
      }

    this.addContact = this.addContact.bind(this);
    this.buttonHandle = this.buttonHandle.bind(this);
 }

 handleChange(e){
  this.setState({
   dateofflight: e.target.value
  })
}

handleChangeC(e){
  this.setState({
   category: e.target.value
  })
  console.log(this.state.category);  
}

handleChangeT(e){
  this.setState({
   time: e.target.value
  })
  
}

handleChangeP(e){
  this.setState({
   place: e.target.value
  })
  
}

buttonHandle() {
  alert('You have chosen the date of flight!');
}

 addContact(event){
    let name  = this.refs.name.value;
    let surname = this.refs.surname.value;
    let passportnumber = this.refs.passportnumber.value;
    let dateofflight = this.refs.dateofflight.value;
    let category = this.refs.category.value;
    let time = this.refs.time.value;
    let place = this.refs.place.value;
    let price;
    let dateofsale = new Date(); 
   
    if (this.refs.place.value>=1 && this.refs.place.value<=3) {
       price = 10000;
    }

    else if (this.refs.place.value>=4 && this.refs.place.value<=5) {
      price = 5000;
   }
    else if (this.refs.place.value>=6 && this.refs.place.value<=7) {
      price = 3000;
  }
          fetch('http://localhost:5000/api/Customer/', {
            method: "post",
            body: JSON.stringify({
              'Name': name,
              'Surname': surname,
              'PassportNumber': passportnumber,
              'DateOfFlight': dateofflight,
           
         
            }),
            headers: {
             
              'Content-Type': 'application/json',
            }
          }).then(response => response.json());

          fetch('http://localhost:5000/api/Detail/', {
            method: "post",
            body: JSON.stringify({
              'CategoryID': category,
              'Place': place,
              'DateOfSale': dateofsale,
              'DateFlight':dateofflight,
              'Price': price,
            }),
            headers: {
              'Content-Type': 'application/json',
            }
          }).then(response => response.json());

          
          fetch('http://localhost:5000/api/Master/', {
            method: "post",
            body: JSON.stringify({
              'CustDocument': passportnumber,
              'CustName': name,
              'CustSurname': surname,
              'DateOfSale': dateofsale,
              
            }),
            headers: {
              'Content-Type': 'application/json',
            }
          }).then(response => response.json());



          fetch('http://localhost:5000/api/Report/', {
            method: "post",
            body: JSON.stringify({
              'CategoryId': category,
              'Place': place,
              'DateOfSale': dateofsale,
              'DateFlight':dateofflight,
              'CustName': name,
              'CustSurname': surname,
              'Price': price,
              'CustDocument': passportnumber,
              
            }),
            headers: {
              'Content-Type': 'application/json',
            }
          }).then(response => response.json());

          
        
    console.log(name);
    console.log(passportnumber);
    console.log(surname);
    console.log(dateofflight);

    console.log(category);
    console.log(time);
    console.log(place);

     this.refs.name.value="";
     this.refs.surname.value="";
     this.refs.passportnumber.value="";
     this.refs.dateofflight.value="";
     this.refs.category.value="";
     this.refs.time.value="";
     this.refs.place.value="";
   
 }


 render(){
     return(
        <div className="editt">
        <form className="froms" onSubmit={this.addContact}>
        <h1 className="name">Buy a ticket now! </h1>
          <input className="inputName"  placeholder=" your name" type="text" ref="name"/>
          <input className="inputName"  placeholder=" your surname" type="text" ref="surname"/><br/>
          <input className="inputName"  placeholder=" Passport number" type="number" ref="passportnumber"/><br/>
          <select id="categories" onChange={this.handleChangeC.bind(this)} ref="category">
          <option value="select">Please, select category</option>
          <option value="1">1</option>
          <option value="2">2</option>
          <option value="3">3</option>
        </select>

         <select id="times" onChange={this.handleChangeT.bind(this)} ref="time">
          <option value="select">Please, select time</option>
          <option value="10:00">10:00</option>
          <option value="12:00">12:00</option>
          <option value="14:00">14:00</option>
        </select>

          <select id="places" onChange={this.handleChangeP.bind(this)} ref="place">
          <option value="select">Please, select place</option>
          <option value="1">1</option>
          <option value="2">2</option>
          <option value="3">3</option>
          <option value="4">4</option>
          <option value="5">5</option>
          <option value="6">6</option>
          <option value="7">7</option>
          <option value="8">8</option>
          <option value="9">9</option>
          <option value="10">10</option>
        </select>
         
       <button type ="submit" id="btns" className="save btn btn-default"><b> Buy</b> </button>
     </form>

       <div className="timetable">
       <div className="NCard" >
      <b> Please, choose the flight date </b> <br/>

        <select id="dates" onChange={this.handleChange.bind(this)} ref="dateofflight">
          <option value="select">Please, select date</option>
          <option value="01.06.2018">01.06.2018</option>
          <option value="02.06.2018">02.06.2018</option>
          <option value="03.06.2018">03.06.2018</option>
        </select>


       <button type ="submit" id="btns" className="save btn btn-default" onClick={this.buttonHandle}><b> GO</b> </button>
      
      
       </div>
        
        </div>
     </div>
     );
 }
}
export default Add;