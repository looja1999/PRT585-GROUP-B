import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PersonComponent } from './person/person.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RoleComponent } from './components/sys-admin/role/role.component';
import { AddRolesComponent } from './components/sys-admin/role/add-roles/add-roles.component';
import { UnitListComponent } from './components/coordinator/unit-list/unit-list.component';
import { CoordinatorComponent } from './components/coordinator/coordinator.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EditRolesComponent } from './components/sys-admin/role/edit-roles/edit-roles.component';
import { ReportListComponent } from './components/coordinator/report-list/report-list.component';
import { CourseListComponent } from './components/coordinator/course-list/course-list.component';
import { AddCourseComponent } from './components/coordinator/add-course/add-course.component';
import { EditCourseComponent } from './components/coordinator/edit-course/edit-course.component';
import { AddUnitComponent } from './components/coordinator/add-unit/add-unit.component';
import { EditUnitComponent } from './components/coordinator/edit-unit/edit-unit.component';
import { AddReportComponent } from './components/coordinator/add-report/add-report.component';
import { EditReportComponent } from './components/coordinator/edit-report/edit-report.component';
import { FeatureComponent } from './components/sys-admin/feature/feature/feature.component';
import { AddFeatureComponent } from './components/sys-admin/feature/add-feature/add-feature.component';
import { EditFeatureComponent } from './components/sys-admin/feature/edit-feature/edit-feature.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { LoginComponent } from './components/login/login.component';
import { GReportListComponent } from './components/graduation/greport-list/greport-list.component';
import { AddGReportComponent } from './components/graduation/add-greport/add-greport.component';
import { EditGReportComponent } from './components/graduation/edit-greport/edit-greport.component';
import { GdReportListComponent } from './components/graduation/gdreport-list/gdreport-list.component';
import { AddGdReportComponent } from './components/graduation/add-gdreport/add-gdreport.component';
import { EditGdReportComponent } from './components/graduation/edit-gdreport/edit-gdreport.component';

@NgModule({
  declarations: [
    AppComponent,
    PersonComponent,
    RoleComponent,
    AddRolesComponent,
    UnitListComponent,
    CoordinatorComponent,
    EditRolesComponent,
    ReportListComponent,
    CourseListComponent,
    AddCourseComponent,
    EditCourseComponent,
    AddUnitComponent,
    EditUnitComponent,
    AddReportComponent,
    EditReportComponent,
    FeatureComponent,
    AddFeatureComponent,
    EditFeatureComponent,
    DashboardComponent,
    LoginComponent,
    GReportListComponent,
    AddGReportComponent,
    EditGReportComponent,
    GdReportListComponent,
    AddGdReportComponent,
    EditGdReportComponent,
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
