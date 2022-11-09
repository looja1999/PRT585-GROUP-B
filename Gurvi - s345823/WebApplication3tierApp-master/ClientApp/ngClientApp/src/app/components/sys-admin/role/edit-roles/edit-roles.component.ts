import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Role } from 'src/app/models/role.model';
import { RolesService } from 'src/app/services/roles.service';

@Component({
  selector: 'app-edit-roles',
  templateUrl: './edit-roles.component.html',
  styleUrls: ['./edit-roles.component.less'],
})
export class EditRolesComponent implements OnInit {
  roleDetails: Role = {
    roleId: 0,
    roleName: '',
    roleStatus: '',
  };

  constructor(
    private route: ActivatedRoute,
    private rolesService: RolesService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = Number(params.get('id'));

        if (id) {
          this.rolesService.getRole(id).subscribe({
            next: (data) => {
              console.log(data);
              this.roleDetails = data;
            },
            error: (msg) => {
              console.log(msg);
            },
          });
        }
      },
    });
  }

  updateRole() {
    this.rolesService
      .updateRole(this.roleDetails.roleId, this.roleDetails)
      .subscribe({
        next: (res) => this.router.navigate(['role']),
        error: (msg) => console.error(msg),
      });
  }

  deleteRole(id: number) {
    this.rolesService.deleteRoles(id).subscribe({
      next: (res) => this.router.navigate(['role']),
    });
  }
}
