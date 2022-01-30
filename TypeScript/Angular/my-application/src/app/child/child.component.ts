import { Component, OnInit } from '@angular/core';

// декоратор
@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css', 
            "../app.component.css"]
})
export class ChildComponent implements OnInit {
  text : string = "Просто текст";
  ngOnInit(): void {
  }
}
