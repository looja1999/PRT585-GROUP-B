import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { AddRolesComponent } from './components/sys-admin/role/add-roles/add-roles.component';
import { RoleComponent } from './components/sys-admin/role/role.component';
import { PersonComponent } from './person/person.component';
import { UnitListComponent } from './components/coordinator/unit-list/unit-list.component';
import { CoordinatorComponent } from './components/coordinator/coordinator.component';
import { FormsModule } from '@angular/forms';
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


const routes: Routes = [
  { path: '', component: DashboardComponent},
  { path: 'login', component: LoginComponent},
  { path: 'person', component: PersonComponent },
  { path: 'role', component: RoleComponent },
  { path: 'role/add-role', component: AddRolesComponent },
  { path: 'role/edit-role/:id', component: EditRolesComponent },
  { path: 'coordinator', component: CoordinatorComponent },
  { path: 'unit', component: UnitListComponent },
  { path: 'unit/add-unit', component: AddUnitComponent},
  { path: 'unit/edit-unit/:id', component: EditUnitComponent },
  { path: 'report', component: ReportListComponent},
  { path: 'report/add-report', component: AddReportComponent},
  { path: 'report/edit-report/:id', component: EditReportComponent },
  { path: 'course', component: CourseListComponent},
  { path: 'course/add-course', component: AddCourseComponent},
  { path: 'course/edit-course/:id', component: EditCourseComponent },
  { path: 'feature', component: FeatureComponent},
  { path: 'feature/add-feature', component: AddFeatureComponent},
  { path: 'feature/edit-feature/:id', component: EditFeatureComponent},
  { path: 'greport', component: GReportListComponent},
  { path: 'greport/add-greport', component: AddGReportComponent},
  { path: 'greport/edit-greport/:id', component: EditGReportComponent },
  { path: 'gdreport', component: GdReportListComponent},
  { path: 'gdreport/add-gdreport', component: AddGdReportComponent},
  { path: 'gdreport/edit-gdreport/:id', component: EditGdReportComponent }

];

@NgModule({
  imports: [
    RouterModule.forRoot(routes),
    BrowserModule,
    CommonModule,
    FormsModule,
  ],
  exports: [RouterModule],
})
export class AppRoutingModule {}
