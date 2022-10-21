import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CourseList } from 'src/app/models/course-list.model';
import { CourseListService } from 'src/app/services/course-list.service';

@Component({
  selector: 'app-add-course',
  templateUrl: './add-course.component.html',
  styleUrls: ['./add-course.component.less']
})
export class AddCourseComponent implements OnInit {
  errors: string[] = [];
  addCourseRequest: CourseList = {
    courseId: 0,
    courseCode: '',
    courseName: '',
  };

  constructor(private courselistService: CourseListService, private router: Router) {}

  ngOnInit(): void {    
  }
  addCourse() {
    this.errors = [];
    console.log(this.addCourseRequest);
    this.courselistService.addCourse(this.addCourseRequest).subscribe({
      next: (courselists) => {
        console.log(courselists);
        this.router.navigate(['course']);
      },
      error: (msg) => {
        console.error(msg);
        this.errors.push(msg.error);
      },
    });    
  }
}
