import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.less']
})
export class PersonComponent {

  public person: Person[] = [];

  constructor(http: HttpClient) {
    http.get<Person[]>('https://localhost:7246/Person').subscribe(result => {
      this.person = result;
    }, error => console.error(error));
  }

}

interface Person {
  name1: string;
  name2: string;
  nickname: string;
  birth: string;
}