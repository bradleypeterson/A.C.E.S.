import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { OverviewComponent } from './pages/overview/overview.component';
import { CourseComponent } from './pages/course/course.component';
import { SectionComponent } from './pages/section/section.component';
import { StudentsComponent } from './pages/students/students.component';

const routes: Routes = [
  { path: '', component: OverviewComponent },
  { path: 'course/:id', component: CourseComponent },
  { path: 'section/:id', component: SectionComponent },
  { path: 'students', component: StudentsComponent },
  { path: 'settings', component: StudentsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
