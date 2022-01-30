import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  public title = "My-Application";
  public client = new User("Вебер", 14);
  public text : string = "Какой-то текст";
  public name : string = "Чье-то имя";
  public isColored : boolean = false;
  public clicks = 0;

  public onClick() : void {
    console.log("Click");
  }
  public onChangeCounter(event:any):void {
    console.log(event);
    event === true ? this.clicks++ : this.clicks--;
  }
}

class User {
  constructor(name : string, age : number){
    this.name = name;
    this.age = age;
  }

  public error:string = "";

  private _name:string = "";
  public set name(value:string){
    this._name = value;
  }
  public get name():string{
    return this._name;
  }

  private _age : number = 0;
  public set age(value:number){
    if(value < 0 || value >= 110){
      const errText = "Присвоено неверное значение!";
      console.log(errText);
      this.error = errText;
    }
    else {
      this._age = value;
      this.error = "";
    }
  }
  public get age():number{
    return this._age;
  }
}
