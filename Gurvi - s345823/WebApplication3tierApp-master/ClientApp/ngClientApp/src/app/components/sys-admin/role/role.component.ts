import { Component, OnInit } from '@angular/core';
import { Role } from 'src/app/models/role.model';
import { RolesService } from 'src/app/services/roles.service';

@Component({
  selector: 'app-role',
  templateUrl: './role.component.html',
  styleUrls: ['./role.component.less'],
})
export class RoleComponent implements OnInit {
  constructor(private rolesService: RolesService) {}

  roles: Role[] = [
    // {
    //   roleId : 1,
    //   roleName : "System Admin",
    //   roleStatus : "true"
    // }, {
    //   roleId : 1,
    //   roleName : "System Admin",
    //   roleStatus : "true"
    // },  {
    //   roleId : 1,
    //   roleName : "System Admin",
    //   roleStatus : "true"
    // },  {
    //   roleId : 1,
    //   roleName : "System Admin",
    //   roleStatus : "true"
    // }
  ];

  ngOnInit(): void {
    this.rolesService.getAllRoles().subscribe({
      next: (roles) => {
        this.roles = roles;
        console.log(roles);
      },
    });
  }
}
