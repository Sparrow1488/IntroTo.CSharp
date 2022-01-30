import { Input, Output, Component, EventEmitter } from '@angular/core';

// декоратор
@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css', 
            "../app.component.css"]
})

export class ChildComponent {
  @Input() huyna1:string = "";
  @Output() huyna1Change = new EventEmitter<string>();
  onNameChange(model: string){
        
      this.huyna1 = model;
      this.huyna1Change.emit(model);
  }
}