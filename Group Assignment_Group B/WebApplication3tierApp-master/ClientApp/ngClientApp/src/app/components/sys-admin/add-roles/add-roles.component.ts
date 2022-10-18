import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Role } from 'src/app/models/role.model';
import { RolesService } from 'src/app/services/roles.service';

@Component({
  selector: 'app-add-roles',
  templateUrl: './add-roles.component.html',
  styleUrls: ['./add-roles.component.less'],
})
export class AddRolesComponent implements OnInit {
  addRoleRequest: Role = {
    roleId: 0,
    roleName: '',
    roleStatus: '',
  };

  constructor(private roleServie: RolesService, private router: Router) {}

  ngOnInit(): void {}

  addRole() {
    console.log(this.addRoleRequest);
    this.roleServie.addRole(this.addRoleRequest).subscribe({
      next: (role) => {
        console.log(role);
        this.router.navigate(['role']);
      },
      error: (msg) => {
        console.error(msg);
      },
    });
  }
}
