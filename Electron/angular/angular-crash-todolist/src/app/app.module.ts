import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TodosComponent } from './components/todos/todos.component';
import { MenuComponent } from './components/menu/menu.component';
import { CourseMenuComponent } from './components/course-menu/course-menu.component';
import { HeaderComponent } from './components/header/header.component';
import { SectionMenuComponent } from './components/section-menu/section-menu.component';
import { CourseComponent } from './pages/course/course.component';
import { SectionComponent } from './pages/section/section.component';
import { StudentsComponent } from './pages/students/students.component';
import { OverviewComponent } from './pages/overview/overview.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    TodosComponent,
    MenuComponent,
    CourseMenuComponent,
    HeaderComponent,
    SectionMenuComponent,
    CourseComponent,
    SectionComponent,
    StudentsComponent,
    OverviewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NoopAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
