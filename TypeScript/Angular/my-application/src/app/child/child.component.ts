import { Input, Output, Component, OnInit, EventEmitter } from '@angular/core';

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

  @Output() onClicked = new EventEmitter<boolean>();
  public click(value:any):void {
    this.onClicked.emit(value);
  }
  ngOnInit(): void { }
}
