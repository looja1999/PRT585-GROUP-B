import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PersonComponent } from './person/person.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { SysAdminComponent } from './components/sys-admin/sys-admin.component';
import { RoleComponent } from './components/sys-admin/role/role.component';
import { AddRolesComponent } from './components/sys-admin/add-roles/add-roles.component';
import { UnitListComponent } from './components/coordinator/unit-list/unit-list.component';
import { CoordinatorComponent } from './components/coordinator/coordinator.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EditRolesComponent } from './components/sys-admin/edit-roles/edit-roles.component';

@NgModule({
  declarations: [
    AppComponent,
    PersonComponent,
    SysAdminComponent,
    RoleComponent,
    AddRolesComponent,
    UnitListComponent,
    CoordinatorComponent,
    EditRolesComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NgbModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
