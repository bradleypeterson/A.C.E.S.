import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-section-menu',
  templateUrl: './section-menu.component.html',
  styleUrls: ['./section-menu.component.css']
})
export class SectionMenuComponent implements OnInit {
  sections: string[];

  constructor() { }

  ngOnInit(): void {
    // Get all sections for the current user that is active
    this.sections = ['Section 1', 'Section 2'];
  }

}
