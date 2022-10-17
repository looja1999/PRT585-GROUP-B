import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { RoleComponent } from './components/sys-admin/role/role.component';
import { SysAdminComponent } from './components/sys-admin/sys-admin.component';
import { PersonComponent } from './person/person.component';

const routes: Routes = [
  { path: 'person', component: PersonComponent },
  { path: 'role', component: RoleComponent },
  { path: 'sys-admin', component: SysAdminComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes), BrowserModule, CommonModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
