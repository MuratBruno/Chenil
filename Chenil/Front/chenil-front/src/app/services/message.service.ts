import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Config } from '../config/config';
import { Message } from '../model/message';
import { catchError } from 'rxjs/operators';

@Injectable({ providedIn: 'root' })
export class MessageService {


  constructor(private http:HttpClient,private config:Config) {

   }

  /** POST: add a new hero to the database */
  sendMessage(message: Message): Observable<Message> {
  return this.http.post<Message>(this.config.backChenilUrl, message)
    .pipe(
      catchError(this.handleError('sendMessage', message))
    );
}


  private handleError<T>(operation:string = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error); 
      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}
