import { Component, OnInit } from '@angular/core';
import { CourseList } from 'src/app/models/course-list.model';
import { CourseListService } from 'src/app/services/course-list.service';

@Component({
  selector: 'app-course-list',
  templateUrl: './course-list.component.html',
  styleUrls: ['./course-list.component.less'],
  template: `
    <kendo-grid [data]="gridData">
      <kendo-grid-column field="courseId" title="Course ID"> </kendo-grid-column>
      <kendo-grid-column field="courseCode" title="Course Code"> </kendo-grid-column>
      <kendo-grid-column field="courseName" title="Course Name">
      </kendo-grid-column>
    </kendo-grid>
  `,
})
export class CourseListComponent implements OnInit {

  constructor(private courselistService: CourseListService) {} 
  
  courselist:CourseList[] = []
  public gridData = [];
  
  ngOnInit(): void {
    this.courselistService.getAllCourses().subscribe({
      next: (courselist) => {
        this.courselist = courselist;
        console.log(courselist);
        this.gridData = courselist;
      },
    });
  }

}
