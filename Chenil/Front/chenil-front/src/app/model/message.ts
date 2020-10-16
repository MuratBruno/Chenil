export class Message{
    id:number;
    nom:string;
    telephone:string;
    mail:string;
    contenu:string;
    date:Date;


    constructor() {
        this.id=0;
        this.nom='';
        this.mail='';
        this.telephone='';
        this.contenu='';
        this.date = new Date();
     }
}