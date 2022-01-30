import { Input, Component, OnInit } from '@angular/core';

// декоратор
@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css', 
            "../app.component.css"]
})
export class ChildComponent implements OnInit {
  text : string = "Просто текст";
  // и это декораторы
  @Input() name = "";
  @Input() age = 0;
  @Input() someText = "";
  ngOnInit(): void { }
}
