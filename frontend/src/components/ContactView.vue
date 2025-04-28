<template>
    <div class="container py-5">
        <h1 class="display-4 fw-semibold mb-4">Contact Us</h1>
        <form @submit.prevent="submitForm" class="mx-auto" style="max-width: 600px;">
            <div class="mb-3">
                <label for="name" class="form-label fw-medium">Your Name</label>
                <input type="text"
                       class="form-control rounded-3"
                       id="name"
                       v-model="form.name"
                       placeholder="Enter your name">
            </div>

            <div class="mb-3">
                <label for="email" class="form-label fw-medium">Email address</label>
                <input type="email"
                       class="form-control rounded-3"
                       id="email"
                       v-model="form.email"
                       placeholder="Enter your email">
            </div>

            <div class="mb-4">
                <label for="message" class="form-label fw-medium">Message</label>
                <textarea class="form-control rounded-3"
                          id="message"
                          rows="4"
                          v-model="form.message"
                          placeholder="Write your message"></textarea>
            </div>

            <button type="submit" class="btn btn-primary px-4 py-2 rounded-3">Send Message</button>
        </form>
    </div>
</template>

<script>
    import { defineComponent, reactive } from 'vue';

    export default defineComponent({
        name: 'ContactView',
        setup() {
            const form = reactive({
                name: '',
                email: '',
                message: ''
            });

            const submitForm = () => {
                console.log('Form submitted:', form);
                alert('Thank you for your message! We will get back to you soon.');
            };

            return {
                form,
                submitForm
            };
        }
    });
</script>

<style scoped>
    textarea.form-control {
        resize: vertical;
    }
</style>
