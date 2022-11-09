import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CourseList } from 'src/app/models/course-list.model';
import { CourseListService } from 'src/app/services/course-list.service';

@Component({
  selector: 'app-edit-course',
  templateUrl: './edit-course.component.html',
  styleUrls: ['./edit-course.component.less']
})
export class EditCourseComponent implements OnInit {
  courseDetails: CourseList = {
    courseId: 0,
    courseCode: '',
    courseName: '',
  };
  constructor(
    private route: ActivatedRoute,
    private courseService: CourseListService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = Number(params.get('id'));

        if (id) {
          this.courseService.getCourse(id).subscribe({
            next: (data) => {
              console.log(data);
              this.courseDetails = data;
            },
            error: (msg) => {
              console.log(msg);
            },
          });
        }
      },
    });
  }

  updateCourse() {
    this.courseService
      .updateCourse(this.courseDetails.courseId, this.courseDetails)
      .subscribe({
        next: (res) => this.router.navigate(['course']),
        error: (msg) => console.error(msg),
      });
  }

  deleteCourse(id: number) {
    this.courseService.deleteCourse(id).subscribe({
      next: (res) => this.router.navigate(['course']),
    });
  }

}
