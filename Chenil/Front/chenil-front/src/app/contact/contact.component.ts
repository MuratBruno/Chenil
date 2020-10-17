import { Component, Directive, OnInit } from '@angular/core';
import { FormArray, FormBuilder,FormsModule, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Message } from '../model/message';
import { MessageService } from '../services/message.service';


@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  message:Message;
  result:string;
  
  constructor(private fb: FormBuilder,private messageService:MessageService) { 
    this.message = new Message();
    this.result='';
  }

  messageForm: FormGroup = this.fb.group({
    nom: ['', Validators.required],
    mail: ['',[Validators.required,Validators.email]],
    telephone: ['',Validators.required],
    contenu: ['',Validators.required]
  }) ;

  get aliases() {
    return this.messageForm.get('aliases') as FormArray;
  }

  get nom() { return this.messageForm.get('nom'); }

  get nomValid():boolean{
    return this.valid('nom');
  }

  get mailValid():boolean{
    return this.valid('mail');
  }

  get telephoneValid():boolean{
    return this.valid('telephone');
  }

  get contenuValid():boolean{
    return this.valid('contenu');
  }


  valid(champ:string):boolean{
    if (this.messageForm!=null&& this.messageForm.get(champ)!=null&&this.messageForm.get(champ)?.valid!=null){
      if( this.messageForm.get(champ)?.valid==true) {
        return true;
      }
      else {
        return false;
      }
    }else{
      return false;
    }
  }

  ngOnInit(): void {
  }

  onSubmit():void{
    //appel au service
    this.messageService.sendMessage(this.message).subscribe(()=>{
      this.result='Message envoyé avec succès!';
    },
    (error:any)=>{
      this.result='Une erreur est survenue durant l\'envoi du message veuillez reessayer plus tard';
    }
    )
  }
}
