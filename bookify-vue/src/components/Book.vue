<template>
    <div class="wrapper">
        <div class="title">
            {{book.title}}
        </div>
        <div class="author">
            {{book.author}}
        </div>
        <div class="created">
            {{book.dateCreated | humanize}}
        </div>
        <div @click="deleteBook(book.id)" class="delete">X</div>
    </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from 'vue-property-decorator';
import IBook from '../types/Book';
import BookService from '../services/book-service';

const bookService = new BookService();

@Component({
    name: "Book",
    components: {}
})

export default class Book extends Vue {
    @Prop({required: true})
    book!: IBook;

    async deleteBook(id:number){
        console.log('deleting');

        await bookService.deleteBook(id);
        this.$emit('deleted');
    }
}

</script>

<style scoped lang="scss">
    .wrapper{
        margin: 0.8rem;
        padding: 0.4rem;
        border-radius: 1rem;
        box-shadow: 0 1px 3px rgba(0,0,0,0.12), 0 1px 2px rgba(0,0,0,0.24);
        transition: all 0.3s cubic-bezier(.25,.8,.25,1);
        position: relative;
    }

    .title{
        font-size: 1.2rem;
        font-weight: bold;
    }

    .author{
        color: #333;
        font-size: 0.9rem;
    }
    .delete{
        position: absolute;
        top: 10px;
        right: 10px;
        font-size: 0.6rem;
        font-weight: bold;
        color: #CE3355;
        cursor: pointer;
    }
</style>