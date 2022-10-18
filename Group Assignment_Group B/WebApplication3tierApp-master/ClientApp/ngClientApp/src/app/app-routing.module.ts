import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { AddRolesComponent } from './components/sys-admin/add-roles/add-roles.component';
import { RoleComponent } from './components/sys-admin/role/role.component';
import { SysAdminComponent } from './components/sys-admin/sys-admin.component';
import { PersonComponent } from './person/person.component';
import { UnitListComponent } from './components/coordinator/unit-list/unit-list.component';
import { CoordinatorComponent } from './components/coordinator/coordinator.component';


const routes: Routes = [
  { path: 'person', component: PersonComponent },
  { path: 'role', component: RoleComponent },
  { path: 'role/add-role', component: AddRolesComponent},
  { path: 'sys-admin', component: SysAdminComponent},
  { path: 'coordinator', component: CoordinatorComponent},
  { path: 'unit', component: UnitListComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes), BrowserModule, CommonModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
