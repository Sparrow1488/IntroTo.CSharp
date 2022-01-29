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
  public onClick() : void {
    console.log("Click");
  }
}

class User {
  constructor(name : string, age : number){
    this.name = name;
    this.age = age;
  }

  public name : string;
  public age : number;
}
