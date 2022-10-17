import { Component, OnInit } from '@angular/core';
import { Role } from 'src/app/models/role.model';

@Component({
  selector: 'app-role',
  templateUrl: './role.component.html',
  styleUrls: ['./role.component.less']
})
export class RoleComponent implements OnInit {

  constructor() { }

  roles : Role[] = [
    {
      roleId : 1,
      roleName : "System Admin", 
      roleStatus : true
    }, {
      roleId : 1,
      roleName : "System Admin", 
      roleStatus : true
    },  {
      roleId : 1,
      roleName : "System Admin", 
      roleStatus : true
    },  {
      roleId : 1,
      roleName : "System Admin", 
      roleStatus : true
    }
  ]; 

  ngOnInit(): void {
  }

}
