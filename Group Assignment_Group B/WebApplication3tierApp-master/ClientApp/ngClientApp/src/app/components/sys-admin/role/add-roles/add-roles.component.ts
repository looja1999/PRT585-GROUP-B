import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
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

  addRoleForm: FormGroup;

  constructor(private roleServie: RolesService, private router: Router) {
    this.initializeAddRoleForm();
  }

  initializeAddRoleForm = () => {
    this.addRoleForm = new FormGroup({
      roleName: new FormControl('', Validators.required),
      roleStatus: new FormControl('', [
        Validators.required,
        Validators.maxLength(5),
      ]),
    });
  };

  ngOnInit(): void {}

  addRole() {
    console.log(this.addRoleRequest);
    this.addRoleRequest = {
      roleId: 0,
      roleName: '' + this.addRoleForm.get('roleName').value,
      roleStatus: '' + this.addRoleForm.get('roleStatus').value,
    };
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
