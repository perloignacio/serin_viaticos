import { Injectable } from '@angular/core';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { Usuario } from 'src/app/models/Usuario.model';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  private currentUserSubject: BehaviorSubject<Usuario>;
  public currentUser: Observable<Usuario>;

  constructor(private http: HttpClient) {
      this.currentUserSubject = new BehaviorSubject<Usuario>(JSON.parse(localStorage.getItem('currentUser')));
      this.currentUser = this.currentUserSubject.asObservable();
  }

  public get currentUserValue(): Usuario {

      return this.currentUserSubject.value;
  }

  login(username: string, password: string) {
      return this.http.get<any>(`${environment.apiUrl}usuarios/login?usuario=${username}&contra=${password}`)
          .pipe(map(user => {
              // store user details and jwt token in local storage to keep user logged in between page refreshes
              if(user!=null){
                localStorage.setItem('currentUser', JSON.stringify(user));
                this.currentUserSubject.next(user);
                return user;
              }

          }));
  }

  logout() {
      // remove user from local storage to log user out

      localStorage.removeItem('currentUser');
      this.currentUserSubject.next(null);
  }
  todos() {
    return this.http.get<Usuario[]>(`${environment.apiUrl}/usuarios/todos`)
  }
}
