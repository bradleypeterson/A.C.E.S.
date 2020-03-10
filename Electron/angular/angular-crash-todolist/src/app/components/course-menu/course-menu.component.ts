import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-course-menu',
  templateUrl: './course-menu.component.html',
  styleUrls: ['./course-menu.component.css']
})
export class CourseMenuComponent implements OnInit {
  courses: string[];

  constructor() { }

  ngOnInit(): void {
    // Get all courses for the current user
    this.courses = ['CS 1030', 'CS 1410', 'CS 2420'];
  }

}
