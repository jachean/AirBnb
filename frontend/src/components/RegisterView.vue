<template>
    <div class="container auth-container">
        <div class="auth-card">
            <div class="auth-header">
                <h2>Create an Account</h2>
            </div>
            <div class="auth-body">
                <form @submit.prevent="register">
                    <div class="form-group">
                        <label for="username" class="form-label">Username</label>
                        <input type="text"
                               class="form-control"
                               id="username"
                               v-model="form.username"
                               required>
                    </div>
                    <div class="form-group">
                        <label for="email" class="form-label">Email address</label>
                        <input type="email"
                               class="form-control"
                               id="email"
                               v-model="form.email"
                               required>
                    </div>
                    <div class="form-group">
                        <label for="password" class="form-label">Password</label>
                        <input type="password"
                               class="form-control"
                               id="password"
                               v-model="form.password"
                               required>
                    </div>
                    <div class="form-group">
                        <label for="confirmPassword" class="form-label">Confirm Password</label>
                        <input type="password"
                               class="form-control"
                               id="confirmPassword"
                               v-model="form.confirmPassword"
                               required>
                        <p v-if="!passwordsMatch && form.confirmPassword" class="text-danger">
                            Passwords do not match
                        </p>
                    </div>
                    <button type="submit" class="btn custom-btn w-100">Register</button>
                </form>
            </div>
        </div>
    </div>
</template>

<script>
import { defineComponent, reactive, computed } from 'vue';

export default defineComponent({
  name: 'RegisterView',
  setup() {
    const form = reactive({
      username: '',
      email: '',
      password: '',
      confirmPassword: ''
    });

    const passwordsMatch = computed(() => {
      return form.password === form.confirmPassword;
    });

    const register = () => {
      // Handle registration form submission
      if (!passwordsMatch.value) {
        alert('Passwords do not match!');
        return;
      }

      console.log('Registration attempted with:', form);
      // You would typically send this data to a backend API
    };

    return {
      form,
      passwordsMatch,
      register
    };
  }
});
</script>

<style scoped>
    .text-danger {
        color: #dc3545;
        font-size: 14px;
        margin-top: 5px;
    }
</style>