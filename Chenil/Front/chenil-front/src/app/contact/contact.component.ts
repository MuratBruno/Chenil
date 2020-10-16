import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Message } from '../model/message';


@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  message:Message;
  
  messageForm: FormGroup = this.fb.group({
    nom: ['', Validators.required],
    mail: ['',Validators.required],
    telephone: ['',Validators.required],
    contenu: ['',Validators.required]
  }) ;

  get aliases() {
    return this.messageForm.get('aliases') as FormArray;
  }

  constructor(private fb: FormBuilder) { 
    this.message = new Message();
  }

  ngOnInit(): void {
  }

  onSubmit():void{
    //appel au service
  }
}
