import React, { Component } from 'react';
import { Workers } from './components/Workers';
import { Schedule } from './components/Schedule';
import { Add } from './components/Add';
import { Detail } from './components/Detail';
import { Master } from './components/Master';
import { Report } from './components/Report';


import './App.css';
import {
  Route,
  NavLink,
  HashRouter
} from "react-router-dom";
import { Places } from './components/Places';


export default class App extends Component {
  displayName = App.name

  render() {
    return (
      <HashRouter>      
      <div className="App">
        <ul className="header">
        <div className="flex">
        <li><NavLink exact to='/Schedule'>Flights</NavLink></li> 
        <li><NavLink exact to='/Places'>Places</NavLink></li> 
          <li><NavLink exact to='/Add'>New ticket</NavLink></li> 
          <li><NavLink exact to='/Workers'>Customer Info</NavLink></li> 
          <li><NavLink exact to='/Detail'>Detail</NavLink></li> 
          <li><NavLink exact to='/Master'>Master</NavLink></li>
          <li><NavLink exact to='/Report'>Report</NavLink></li> 
  
        
          </div>
        </ul>
        
       <div className="content">
       <Route exact path='/Workers' render={(props) => (
        < Workers/>
       )}/>
         <Route exact path='/Add' render={(props) => (
        < Add/>
       )}/>

       <Route exact path='/Schedule' render={(props) => (
        <Schedule/>
       )}/>

       <Route exact path='/Detail' render={(props) => (
        <Detail/>
       )}/>

        <Route exact path='/Master' render={(props) => (
        <Master/>
       )}/>

      <Route exact path='/Places' render={(props) => (
        <Places/>
       )}/>

      <Route exact path='/Report' render={(props) => (
        <Report/>
       )}/>
       
 

       </div>
     </div>
    </HashRouter>
      
    );
  }
}
