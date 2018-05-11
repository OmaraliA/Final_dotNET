import React, { Component } from 'react';
import '../new.css';
import CustomerList  from './CustomerList'
import Schedule  from './Schedule'

export class Workers extends Component {
  constructor(props) {
    super(props);
    this.state = {
      customers: [],
      categories: [],
      infa: [],
      indx: 0,
      id: 1,
      name: '',
      passportnumber: 0,
      surname: '',
      dateofflight:'',
      flight:'',
      place:0,
      flag: false,
    };
    this.onHandleDelete = this.onHandleDelete.bind(this);
    this.onHandleUpdate = this.onHandleUpdate.bind(this);
    this.onHandleFlag = this.onHandleFlag.bind(this);
  
    
  }
  componentDidMount() {
    this.loadData();

  }

   loadData = async() => {
    fetch('http://localhost:5000/api/Customer/')
      .then(data => data.json())
      .then((data) => {
        this.setState({ customers: data })
      });
    
  }
  



  onHandleDelete = async (remove) => {
    if (remove) {
      return fetch('http://localhost/:5000/api/Customer' + '/' + remove.id, {
        method: 'delete',  
        headers: {
          'Content-Type': 'application/json'
        },
      }).then(res => res).then(()=>this.loadData())
      
      
      
    }
  }
  onHandleFlag() {
    this.setState({
      flag: false
    })
    return fetch('http://localhost:5000/api/Customer/' + this.state.indx, {
      method: 'PUT',
      mode: "cors",
      body: JSON.stringify({
        'name': this.state.infa.name,
        'passportNumber': this.state.infa.passportnumber,
        'surname': this.state.infa.surname,
        'dateOfFlight':this.state.infa.dateofflight,
     
      }),
      headers: {
        'Content-Type': 'application/json'
      }
    }).then(res => res).then(()=>this.loadData())
  
  }
 
  onHandleUpdate(date) {
    this.setState({
      flag: true,
      infa: date,
      indx: date.id
    })
  }


  render() {
    return (
      <div className="col-md-12">
        <div className="col-md-4" id="datas">
          {this.state.customers.map((item, j) => {
            return (
              <div >
              <CustomerList key={j} info={item}/>           
            </div>
            )
          })}

           

        </div>
     
        </div>

    )
  };

};

