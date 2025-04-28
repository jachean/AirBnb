<template>
    <footer class="footer">
        <div class="container">
            <div class="footer-content">
                <p class="copyright">&copy; {{ currentYear }} Airbnb Clone. All rights reserved.</p>
                <router-link to="/privacy" class="footer-link">Privacy Policy</router-link>
            </div>
        </div>
    </footer>
</template>

<script>
import { defineComponent, computed } from 'vue';

export default defineComponent({
  name: 'FooterComponent',
  setup() {
    const currentYear = computed(() => new Date().getFullYear());

    return {
      currentYear
    };
  }
});
</script>

<style scoped>
    .footer {
        background-color: #f7f7f7;
        padding: 25px 0;
        margin-top: 50px;
    }

    .footer-content {
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: column;
        text-align: center;
    }

    .copyright {
        margin-bottom: 10px;
        color: #717171;
    }

    .footer-link {
        color: var(--airbnb-primary);
        text-decoration: none;
    }

        .footer-link:hover {
            text-decoration: underline;
        }
</style>