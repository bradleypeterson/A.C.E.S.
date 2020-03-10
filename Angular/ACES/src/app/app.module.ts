import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { NavComponent } from './components/nav/nav.component';
import { OverviewComponent } from './pages/overview/overview.component';
import { CoursesComponent } from './pages/courses/courses.component';
import { SectionComponent } from './pages/section/section.component';
import { CourseComponent } from './pages/course/course.component';
import { StudentsComponent } from './pages/students/students.component';
import { ChartsModule } from 'ng2-charts';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    NavComponent,
    OverviewComponent,
    CoursesComponent,
    SectionComponent,
    CourseComponent,
    StudentsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ChartsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
