import { Input, Output, Component, EventEmitter } from '@angular/core';

// декоратор
@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css', 
            "../app.component.css"]
})

export class ChildComponent {
  private _personName:string = "";
  @Input() public get personName():string {
    return this._personName;
  };
  public set personName(value:string) {
    this._personName = value
    this.onAccept(false);
  }
  @Input() accepted:boolean = false;

  @Output() personNameChange = new EventEmitter<string>(); // эта помойка должна называться так же, как и свойство
  @Output() acceptedChange = new EventEmitter<boolean>();
  
  public onNameChange(model: string):void {
      this.personName = model;
      this.personNameChange.emit(model);
  }

  public onAccept(isAccepted:boolean):void {
    if(!this.isNameValid(this.personName)){
      isAccepted = false;
    }
    this.accepted = isAccepted;
    this.acceptedChange.emit(isAccepted);
  }

  private isNameValid(checkName:string):boolean {
    let result = false;
    if(checkName.length > 1){
      result = true;
    }
    return result;
  }
}