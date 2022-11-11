import { Component, OnInit } from '@angular/core';
import { CourseList } from 'src/app/models/course-list.model';
import { CourseListService } from 'src/app/services/course-list.service';

@Component({
  selector: 'app-course-list',
  templateUrl: './course-list.component.html',
  styleUrls: ['./course-list.component.less']
})
export class CourseListComponent implements OnInit {

  constructor(private courselistService: CourseListService) {} 
  
  courselist:CourseList[] = []
  
  ngOnInit(): void {
    this.courselistService.getAllCourses().subscribe({
      next: (courselist) => {
        this.courselist = courselist;
        console.log(courselist);
      },
    });
  }

}
