import { Component, OnInit } from '@angular/core';
import { CourseList } from 'src/app/models/course-list.model';
import { Feature } from 'src/app/models/feature.model';
import { ReportList } from 'src/app/models/report-list.model';
import { Role } from 'src/app/models/role.model';
import { UnitList } from 'src/app/models/unit-list.model';
import { CourseListService } from 'src/app/services/course-list.service';
import { FeaturesService } from 'src/app/services/features.service';
import { ReportListService } from 'src/app/services/report-list.service';
import { RolesService } from 'src/app/services/roles.service';
import { UnitListService } from 'src/app/services/unit-list.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.less']
})
export class DashboardComponent implements OnInit {

  roles : Role[] = []; 
  units : UnitList[] = [];
  courses : CourseList[] = [];
  features : Feature[] = [];
  reports : ReportList[] = [];

  constructor(private rolesService : RolesService, private unitsService : UnitListService, private coursesService : CourseListService,
    private featuresService : FeaturesService, private reportsService : ReportListService) { }

  ngOnInit(): void {
    this.rolesService.getAllRoles().subscribe({
      next : res => this.roles = res, 
      error : err => console.error(err)
    }); 
    
    this.unitsService.getAllUnits().subscribe({
      next : res => this.units = res, 
      error : err => console.error(err)
    })
    this.coursesService.getAllCourses().subscribe({
      next : res => this.courses = res, 
      error : err => console.error(err)
    })
    this.featuresService.getAllFeatures().subscribe({
      next : res => this.features = res, 
      error : err => console.error(err)
    })
    this.reportsService.getAllReports().subscribe({
      next : res => this.reports = res, 
      error : err => console.error(err)
    })

  }
}
