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

@NgModule({
  declarations: [AppComponent, PersonComponent, SysAdminComponent, RoleComponent],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NgbModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
