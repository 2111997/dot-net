import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import {User}from './user.model';
@Component({

  templateUrl: './user.component.html',
})
export class UserComponent {
   
  constructor(public httpc:HttpClient){}
title = 'e-commerce-project';

UserModel:User=new User();

AddUser(){
 console.log(this.UserModel);
var userto={
  UserName:this.UserModel.UserName,
  UserLastName:this.UserModel.UserLastName,
  UserAddress:this.UserModel.Address,
  Gender:this.UserModel.Gender,
}

this.httpc.post("https://localhost:44398/api/Users",userto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
this.UserModel = new User();
}
PostSuccess(res:any){
  console.log(res);
  
}
PostError(res:any){
  console.log(res);
}

}
