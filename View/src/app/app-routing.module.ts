import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddBookComponent } from './add-book/add-book.component';
import { EditBookComponent } from './edit-book/edit-book.component';
import { ListBookComponent } from './list-book/list-book.component';
import { AddAuthorComponent } from './add-author/add-author.component';

const routes: Routes = [
    { path:  '', redirectTo:  'books', pathMatch:  'full' },
{
    path:  'add-book',
    component:  AddBookComponent
},
{
    path:  'edit-book',
    component:  EditBookComponent
},
{
    path:  'list-book',
    component:  ListBookComponent
},
{
    path:  'add-author',
    component: AddAuthorComponent
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }