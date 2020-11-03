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
  success:boolean;
  messageEnvoye:boolean;
  
  constructor(private fb: FormBuilder,private messageService:MessageService) { 
    this.message = new Message();
    this.result='';
    this.success=false;
    this.messageEnvoye=false;
  }

  messageForm: FormGroup = this.fb.group({
    nom: ['', Validators.required],
    mail: ['',[Validators.required,Validators.email]],
    //Le regex suivant permet de valider les numéros de type xx.xx.xx.xx.xx ou xx xx xx xx xx
    telephone: ['',[Validators.required,  Validators.pattern("[0-9]{2}[. ]{0,1}[0-9]{2}[. ]{0,1}[0-9]{2}[. ]{0,1}[0-9]{2}[. ]{0,1}[0-9]{2}")]],
    objet:['',Validators.required],
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

  get objetValid():boolean{
    return this.valid('objet');
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
    //initiallisation du message
    this.message.contenu=this.messageForm.get('contenu')?.value;
    this.message.mail=this.messageForm.get('mail')?.value;
    this.message.telephone=this.messageForm.get('telephone')?.value;
    this.message.nom=this.messageForm.get('nom')?.value;


    //appel au service
    this.messageService.sendMessage(this.message).subscribe(()=>{
      this.result='Message envoyé avec succès!';
      this.success=true;
      this.messageEnvoye=true;
    },
    (error:any)=>{
      this.result='Une erreur est survenue durant l\'envoi du message veuillez reessayer plus tard';
      this.success=false;
      this.messageEnvoye=true;
    }
    )
  }
}
